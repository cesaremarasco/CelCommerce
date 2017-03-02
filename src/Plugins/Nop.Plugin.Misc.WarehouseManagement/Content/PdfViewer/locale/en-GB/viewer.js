# Copyright 2012 Mozilla Foundation
#
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
#
#     http://www.apache.org/licenses/LICENSE-2.0
#
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.

# Main toolbar buttons (tooltips and alt text for images)
previous.title=Previous Page
previous_label=Previous
next.title=Next Page
next_label=Next

# LOCALIZATION NOTE (page_label, page_of):
# These strings are concatenated to form the "Page: X of Y" string.
# Do not translate "{{pageCount}}", it will be substituted with a number
# representing the total number of pages.
page_label=Page:
page_of=of {{pageCount}}

zoom_out.title=Zoom Out
zoom_out_label=Zoom Out
zoom_in.title=Zoom In
zoom_in_label=Zoom In
zoom.title=Zoom
presentation_mode.title=Switch to Presentation Mode
presentation_mode_label=Presentation Mode
open_file.title=Open File
open_file_label=Open
print.title=Print
print_label=Print
download.title=Download
download_label=Download
bookmark.title=Current view (copy or open in new window)
bookmark_label=Current View

# Secondary toolbar and context menu
tools.title=Tools
tools_label=Tools
first_page.title=Go to First Page
first_page.label=Go to First Page
first_page_label=Go to First Page
last_page.title=Go to Last Page
last_page.label=Go to Last Page
last_page_label=Go to Last Page
page_rotate_cw.title=Rotate Clockwise
page_rotate_cw.label=Rotate Clockwise
page_rotate_cw_label=Rotate Clockwise
page_rotate_ccw.title=Rotate Anti-Clockwise
page_rotate_ccw.label=Rotate Anti-Clockwise
page_rotate_ccw_label=Rotate Anti-Clockwise

hand_tool_enable.title=Enable hand tool
hand_tool_enable_label=Enable hand tool
hand_tool_disable.title=Disable hand tool
hand_tool_disable_label=Disable hand tool

# Document properties dialog box
document_properties.title=Document Properties…
document_properties_label=Document Properties…
document_properties_file_name=File name:
document_properties_file_size=File size:
# LOCALIZATION NOTE (document_properties_kb): "{{size_kb}}" and "{{size_b}}"
# will be replaced by the PDF file size in kilobytes, respectively in bytes.
document_properties_kb={{size_kb}} kB ({{size_b}} bytes)
# LOCALIZATION NOTE (document_properties_mb): "{{size_mb}}" and "{{size_b}}"
# will be replaced by the PDF file size in megabytes, respectively in bytes.
document_properties_mb={{size_mb}} MB ({{size_b}} bytes)
document_properties_title=Title:
document_properties_author=Author:
document_properties_subject=Subject:
document_properties_keywords=Keywords:
document_properties_creation_date=Creation Date:
document_properties_modification_date=Modification Date:
# LOCALIZATION NOTE (document_properties_date_string): "{{date}}" and "{{time}}"
# will be replaced by the creation/modification date, and time, of the PDF file.
document_properties_date_string={{date}}, {{time}}
document_properties_creator=Creator:
document_properties_producer=PDF Producer:
document_properties_version=PDF Version:
document_properties_page_count=Page Count:
document_properties_close=Close

# Tooltips and alt text for side panel toolbar buttons
# (the _label strings are alt text for the buttons, the .title strings are
# tooltips)
toggle_sidebar.title=Toggle Sidebar
toggle_sidebar_label=Toggle Sidebar
outline.title=Show Document Outline
outline_label=Document Outline
attachments.title=Show Attachments
attachments_label=Attachments
thumbs.title=Show Thumbnails
thumbs_label=Thumbnails
findbar.title=Find in Document
findbar_label=Find

# Thumbnails panel item (tooltip and alt text for images)
# LOCALIZATION NOTE (thumb_page_title): "{{page}}" will be replaced by the page
# number.
thumb_page_title=Page {{page}}
# LOCALIZATION NOTE (thumb_page_canvas): "{{page}}" will be replaced by the page
# number.
thumb_page_canvas=Thumbnail of Page {{page}}

# Find panel button title and messages
find_label=Find:
find_previous.title=Find the previous occurrence of the phrase
find_previous_label=Previous
find_next.title=Find the next occurrence of the phrase
find_next_label=Next
find_highlight=Highlight all
find_match_case_label=Match case
find_reached_top=Reached top of document, continued from bottom
find_reached_bottom=Reached end of document, continued from top
find_not_found=Phrase not found

# Error panel labels
error_more_info=More Information
error_less_info=Less Information
error_close=Close
# LOCALIZATION NOTE (error_version_info): "{{version}}" and "{{build}}" will be
# replaced by the PDF.JS version and build ID.
error_version_info=PDF.js v{{version}} (build: {{build}})
# LOCALIZATION NOTE (error_message): "{{message}}" will be replaced by an
# english string describing the error.
error_message=Message: {{message}}
# LOCALIZATION NOTE (error_stack): "{{stack}}" will be replaced with a stack
# trace.
error_stack=Stack: {{stack}}
# LOCALIZATION NOTE (error_file): "{{file}}" will be replaced with a filename
error_file=File: {{file}}
# LOCALIZATION NOTE (error_line): "{{line}}" will be replaced with a line number
error_line=Line: {{line}}
rendering_error=An error occurred while rendering the page.

# Predefined zoom values
page_scale_width=Page Width
page_scale_fit=Page Fit
page_scale_auto=Automatic Zoom
page_scale_actual=Actual Size
# LOCALIZATION NOTE (page_scale_percent): "{{scale}}" will be replaced by a
# numerical scale value.
page_scale_percent={{scale}}%

# Loading indicator messages
loading_error_indicator=Error
loading_error=An error occurred while loading the PDF.
invalid_file_error=Invalid or corrupted PDF file.
missing_file_error=Missing PDF file.
unexpected_response_error=Unexpected server response.

# LOCALIZATION NOTE (text_annotation_type.alt): This is used as a tooltip.
# "{{type}}" will be replaced with an annotation type from a list defined in
# the PDF spec (32000-1:2008 Table 169 – Annotation types).
# Some common types are e.g.: "Check", "Text", "Comment", "Note"
text_annotation_type.alt=[{{type}} Annotation]
password_label=Enter the password to open this PDF file.
password_invalid=Invalid password. Please try again.
password_ok=OK
password_cancel=Cancel

printing_not_supported=Warning: Printing is not fully supported by this browser.
printing_not_ready=Warning: The PDF is not fully loaded for printing.
web_fonts_disabled=Web fonts are disabled: unable to use embedded PDF fonts.
document_colors_not_allowed=PDF documents are not allowed to use their own colours: 'Allow pages to choose their own colours' is deactivated in the browser.
